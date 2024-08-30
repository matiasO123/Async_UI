using Newtonsoft.Json;
using System.Diagnostics;

namespace UI_Async
{
    public partial class Form1 : Form
    {
        private string api_url = "";
        HttpClient httpClient;
        private CancellationTokenSource cancellationToken;

        public Form1()
        {
            InitializeComponent();
            api_url = "https://localhost:7247";
            httpClient = new HttpClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            Application.DoEvents();
            //This blocks the thread and the app
            Thread.Sleep(int.Parse(textBox7.Text));
            pictureBox1.Visible = false;
            MessageBox.Show("This blocks the thread and the app");

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            Application.DoEvents();
            //this release the thread, but waits until the next statement is finished to continue with the next one. 
            await Waiting();

            //if i invoke like this without the 'await' statement, the process will go further not waiting for the result. In this case, the image will not be visible.
            pictureBox2.Visible = false;
            MessageBox.Show("this release the thread, but waits until the next statement is finished to continue with the next one. Click again and try to drag and drop the form. It is possibly now; but not in the first button");
        }

        private async Task Waiting()
        {
            await Task.Delay(int.Parse(textBox7.Text));
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            Application.DoEvents();
            //this release the thread, but waits until the next statement is finished to continue with the next one. 

            string name = textBox_name.Text;

            try
            {
                string result = await GetName(name);
                MessageBox.Show($"The app is not block. Now you are interacting with an API!!!. The API is saying {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            //if i invoke like this without the 'await' statement, the process will go further not waiting for the result. In this case, the image will not be visible.
            pictureBox3.Visible = false;

        }

        private async Task<string> GetName(string name)
        {
            string url = $"{api_url}/example/GetName/{name}";
            using (var response = await httpClient.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            Application.DoEvents();
            //this release the thread, but waits until the next statement is finished to continue with the next one. 
            var cc = await GetCreditCards(int.Parse(textBox9.Text));
            //starts the stopwatch
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //Control of the situation
            try
            {
                //This release the thread but waits until the task is completed before going forward
                await Process_CC(cc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
            stopwatch.Stop();
            MessageBox.Show($"Lets make a few async processing. The whole process took {stopwatch.ElapsedMilliseconds} miliseconds!");

            //if i invoke like this without the 'await' statement, the process will go further not waiting for the result. In this case, the image will not be visible.
            pictureBox4.Visible = false;
        }

        private async Task<List<string>> GetCreditCards(int creditCard_quant)
        {
            var cc = new List<string>();
            await Task.Run(() =>
            {
                for (int i = 0; i < creditCard_quant; i++)
                {
                    cc.Add(i.ToString().PadLeft(16, '0'));
                }
            });
            return cc;
        }

        private async Task Process_CC(List<string> cc, CancellationToken cancellationToken = default)
        {
            var tasks = new List<Task>();
            int index = 0;
            await Task.Run(() =>
            {
                foreach (var credit_card in cc)
                {
                    var json = JsonConvert.SerializeObject(credit_card);
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    string url = $"{api_url}/api/Card";
                    var responseTask = httpClient.PostAsync(url, content, cancellationToken);
                    tasks.Add(responseTask);
                }
            });
            //wait for all the tasks to be finished
            await Task.WhenAll(tasks);
        }


        private async Task Process_CC_progress(List<string> cc, IProgress<int> progress = null)
        {
            var tasks = new List<Task>();
            int totalCount = cc.Count;
            int processedCount = 0;

            foreach (var credit_card in cc)
            {
                tasks.Add(Task.Run(async () =>
                {
                    var json = JsonConvert.SerializeObject(credit_card);
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    string url = $"{api_url}/api/Card";

                    await httpClient.PostAsync(url, content);

                    // Report progress
                    if (progress != null)
                    {
                        int newProgress;
                        // Using Interlocked to safely increment the processedCount
                        newProgress = (int)Math.Round((double)Interlocked.Increment(ref processedCount) / totalCount * 100, 0);
                        progress.Report(newProgress);
                    }
                }));
            }

            await Task.WhenAll(tasks);

        }


        private void Report_Card_Progress(int percent)
        {
            progressBar1.Value = percent;
        }



        private async void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            Application.DoEvents();
            var reportProgress = new Progress<int>(Report_Card_Progress);
            //this release the thread, but waits until the next statement is finished to continue with the next one. 
            var cc = await GetCreditCards(int.Parse(textBox9.Text));
            //starts the stopwatch
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //Control of the situation
            try
            {
                //This release the thread but waits until the task is completed before going forward
                await Process_CC_progress(cc, reportProgress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
            stopwatch.Stop();
            MessageBox.Show($"Lets make a few async processing. The whole process took {stopwatch.ElapsedMilliseconds} miliseconds!");

            //if i invoke like this without the 'await' statement, the process will go further not waiting for the result. In this case, the image will not be visible.
            pictureBox5.Visible = false;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            cancellationToken = new CancellationTokenSource();
            cancellationToken.CancelAfter(int.Parse(textBox8.Text));
            pictureBox6.Visible = true;
            Application.DoEvents();
            //this release the thread, but waits until the next statement is finished to continue with the next one. 
            var cc = await GetCreditCards(int.Parse(textBox9.Text));
            //starts the stopwatch
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //Control of the situation
            try
            {
                //This release the thread but waits until the task is completed before going forward
                await Process_CC(cc, cancellationToken.Token);
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("La aplicación ha sido cancelada. " + e.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
            }
            stopwatch.Stop();
            MessageBox.Show($"Lets make a few async processing. The whole process took {stopwatch.ElapsedMilliseconds} miliseconds!");

            //if i invoke like this without the 'await' statement, the process will go further not waiting for the result. In this case, the image will not be visible.
            pictureBox6.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cancellationToken.Cancel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
