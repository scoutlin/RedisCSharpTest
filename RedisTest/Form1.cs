using ServiceStack.Redis;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisTest
{
    public partial class Form1 : Form
    {

        private ConnectionMultiplexer gRedis;
        private RedisClient gRedisClient;
        private int gFuckTimes;
        private string gTestSet;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_CreateRedis_Click(object sender, EventArgs e)
        {
            button_CreateRedis.Enabled = false;
            button_StartRead.Enabled = false;
            button_StartDelete.Enabled = false;


            //Init 
            var rt = int.TryParse(textBox1.Text, out gFuckTimes);
            gTestSet = textBox2.Text;

            if(rt == false)
            {
                MessageBox.Show("You forget input the times or you`re MORON!!");

                Close();
            }

            // ^^^ store and re-use this!!!
            gRedis = ConnectionMultiplexer.Connect("192.168.4.109:6379");
            //gRedis redis = ConnectionMultiplexer.Connect("server1:6379,server2:6379"); 

            Trace.WriteLine(gRedis.GetStatus());

            button_StartWrite.Enabled = true;
        }

        private void button_StartWrite_Click(object sender, EventArgs e)
        {
            button_CreateRedis.Enabled = false;
            button_StartWrite.Enabled = false;
            button_StartDelete.Enabled = false;

            try
            {
                IDatabase db = gRedis.GetDatabase();

                string keyName = string.Empty;
                for (int i = 0; i < gFuckTimes; i++)
                {
                    keyName = "CShartTest:";
                    keyName += i.ToString();

                    bool writeResult = db.StringSet(keyName, "SeqNO" + i.ToString());
                    
                    if (writeResult != true)
                    {
                        MessageBox.Show("Write Fail at " + i.ToString());
                        return;
                    }

                    Thread.Sleep(1);
                }

                button_StartRead.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }         
        }

        private void button_StartRead_Click(object sender, EventArgs e)
        {
            button_CreateRedis.Enabled = false;
            button_StartWrite.Enabled = false;
            button_StartRead.Enabled = false;
            

            try
            {
                IDatabase db = gRedis.GetDatabase();

                string outputString = string.Empty;
                string keyName = string.Empty;
                for (int i = 0; i < gFuckTimes; i++)
                {
                    keyName = "CShartTest:";
                    keyName += i.ToString();

                    outputString += db.StringGet(keyName) + ", ";

                    Thread.Sleep(1);
                }

                MessageBox.Show(outputString);

                button_StartDelete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_StartDelete_Click(object sender, EventArgs e)
        {           
            button_StartWrite.Enabled = false;
            button_StartRead.Enabled = false;
            button_StartDelete.Enabled = false;

            try
            {
                IDatabase db = gRedis.GetDatabase();
             
                string outputString = string.Empty;
                string keyName = string.Empty;
                for (int i = 0; i < gFuckTimes; i++)
                {
                    keyName = "CShartTest:";
                    keyName += i.ToString();
     
                    bool deleteResult = db.KeyDelete(keyName);
                    if (deleteResult != true)
                    {
                        MessageBox.Show("delete Fail at " + i.ToString());
                        return;
                    }

                    Thread.Sleep(1);
                }

                MessageBox.Show("Done");

                button_CreateRedis.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                
                var redisClientManager = new PooledRedisClientManager("192.168.4.109:6384");
                var gRedisClient = redisClientManager.GetClient();
                

                //Trace.WriteLine(gRedisClient.DbSize);

                //var CShartTest = gRedisClient.Get<string>("CShartTest:0");
                //Trace.WriteLine("CShartTest: " + CShartTest);

                //string AA = "AA";
                //byte[] bytes = Encoding.ASCII.GetBytes(AA);

                //gRedisClient.Set("122", bytes);


                //var setResult = gRedisClient.Set("TEST000000001", "AAA");
                //Trace.WriteLine("setResult: " + setResult);
                //var getA01 = gRedisClient.Get<string>("A:01");
                //Trace.WriteLine("getA01: " + getA01);

                var allKeyList = gRedisClient.GetKeysByPattern("CShartTest:*");
                Trace.WriteLine("allKeyList: " + allKeyList);



                //for (int i = 0; i < allKeyList.Count(); i++)
                //{
                //    foreach (var key in allKeyList)
                //    {
                //        gRedisClient.Delete(key);
                //    }
                //}

                IDatabase db = gRedis.GetDatabase();

                string outputString = string.Empty;
                string keyName = string.Empty;
                foreach (var key in allKeyList)
                {
                    bool deleteResult = db.KeyDelete(key);
                    if (deleteResult != true)
                    {
                        MessageBox.Show("delete Fail at " + key);
                        return;
                    }

                    Thread.Sleep(1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //Trace.WriteLine("allKeyList.count: " + allKeyList.Count);

        }

        private void button_Start_SET_Click(object sender, EventArgs e)
        {
            // ^^^ store and re-use this!!!
            gRedis = ConnectionMultiplexer.Connect("192.168.4.109:6379");
            //gRedis redis = ConnectionMultiplexer.Connect("server1:6379,server2:6379"); 

            MessageBox.Show(gRedis.GetStatus());

            try
            {
                IDatabase db = gRedis.GetDatabase();

                long startTicks = DateTime.Now.Ticks;
                long endTicks = 0;
                double intervalTicks = 0;

                string valueName = string.Empty;
                for (int i = 0; i < 100000; i++)
                {
                    valueName = "SeqNO:";
                    valueName += i.ToString();

                    bool writeResult = db.SetAdd("PresureTest_SET", valueName);

                    if (writeResult != true)
                    {
                        MessageBox.Show("Write Fail at " + i.ToString());
                        return;
                    }

                    Thread.Sleep(1);
                }

                endTicks = DateTime.Now.Ticks;
                intervalTicks = endTicks - startTicks;
                intervalTicks = intervalTicks / Math.Pow(10, 7);
                

                MessageBox.Show("Done!!\n" + 
                                "startTicks:" + startTicks.ToString() + "\n" + 
                                "endTicks:" + endTicks.ToString() + "\n" + 
                                "intervalTicks: " + intervalTicks.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
