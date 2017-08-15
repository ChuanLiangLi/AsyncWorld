using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("【Debug】线程ID:" + Thread.CurrentThread.ManagedThreadId);

            var request = WebRequest.Create("https://github.com/");//为了更好的演示效果，我们使用网速比较慢的外网
            request.GetResponse();//发送请求    

            Debug.WriteLine("【Debug】线程ID:" + Thread.CurrentThread.ManagedThreadId);
            label1.Text = "执行完毕！";
        }
        /// <summary>
        /// 异步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsync_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("[Debug]主线程ID:"+Thread.CurrentThread.ManagedThreadId);
            var request = WebRequest.Create("https://github.com/");
            request.BeginGetResponse(new  AsyncCallback(t=> 
            {
                var response = request.EndGetResponse(t);
                var stream = response.GetResponseStream();
                using (StreamReader reader=new StreamReader (stream))
                {
                    StringBuilder sb = new StringBuilder();
                    while(!reader.EndOfStream)
                    {
                        var content = reader.ReadLine();
                        sb.Append(content);
                    }
                    Debug.WriteLine("【Debug】"+sb.ToString().Trim().Substring(0,100)+".....");
                    Debug.WriteLine("【Debug】异步线程ID:"+Thread.CurrentThread.ManagedThreadId);
                    label1.Invoke((Action)(()=>label1.Text="执行完毕"));

                }
            }),null);
            Debug.WriteLine("【Debug】主线程ID:"+Thread.CurrentThread.ManagedThreadId);
        }

        private void btnEAP_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("【Debug】主线程ID:"+Thread.CurrentThread.ManagedThreadId);
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler((s1,s2)=>
            {
                Thread.Sleep(200);
                Debug.WriteLine("【Debug】异步线程ID:"+Thread.CurrentThread.ManagedThreadId);

            });//注册事件来实现异步
            
            worker.RunWorkerAsync(this);
            Debug.WriteLine("【Debug】主线程ID:"+Thread.CurrentThread.ManagedThreadId);
        }

        private void btnTAP_Click(object sender, EventArgs e)
        {
            var task1 = Task<string>.Run(() =>
            {
                Thread.Sleep(2000);
                Debug.WriteLine("【Debug】task1线程Id:" + Thread.CurrentThread.ManagedThreadId);
                return "张三";
            });
            task1.Wait();
            var value = task1.Result;
            Debug.WriteLine("【Debug】主线程ID:"+Thread.CurrentThread.ManagedThreadId);
            Debug.WriteLine("value:"+value);
        }

        private void btnMoreAsyncSort_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("【Debug】主线程ID:"+Thread.CurrentThread.ManagedThreadId);
            string str1 = string.Empty, str2 = string.Empty, str3 = string.Empty;
            var task1 = Task.Run(()=>
            {
                Thread.Sleep(500);
                str1 = "姓名：张三，";
                Debug.WriteLine("【Debug】task1 线程ID:"+Thread.CurrentThread.ManagedThreadId);

            }).ContinueWith(t=>
            {
                Thread.Sleep(500);
                str2 = "年龄：25，";
                Debug.WriteLine("【Debug】task2 线程ID:"+Thread.CurrentThread.ManagedThreadId);

            }).ContinueWith(t=>
            {
                Thread.Sleep(500);
                str3 = "爱好，妹子";
                Debug.WriteLine("【Debug】task3 线程ID:"+Thread.CurrentThread.ManagedThreadId);
            });
            Thread.Sleep(2000);
            task1.Wait();
            Debug.WriteLine(str1+str2+str3);
            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);

        }
    }
}
