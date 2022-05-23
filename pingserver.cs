public GUI()
        {
            InitializeComponent();
            Thread serverping = new Thread(pingservers);
            serverping.Start();
        }

private void pingservers()
        {
            //Server Status'
            while (!this.IsDisposed)
            {
                server = "serverip";
                server1 = "serverip";
                server2 = "serverip";

                //Server 1
                try
                {
                    Ping p = new Ping();
                    PingReply r;

                    r = p.Send(server);

                    if (r.Status == IPStatus.Success)
                    {
                        serverone.Invoke((MethodInvoker)(() => serverone.Text = "Online " + r.RoundtripTime.ToString() + " ms" + "\n"));
                        serverone.ForeColor = Color.Lime;
                    }
                }
                catch (PingException e)
                {
                    serverone.Invoke((MethodInvoker)(() => serverone.Text = "Offline"));
                    serverone.ForeColor = Color.Red;
                }

            Thread.Sleep(50);

                //Server 2
                try
                {

                    Ping p1 = new Ping();
                    PingReply r1;
                    r1 = p1.Send(server1);


                    if (r1.Status == IPStatus.Success)
                    {
                        servertwo.Invoke((MethodInvoker)(() => servertwo.Text = "Online " + r1.RoundtripTime.ToString() + " ms" + "\n"));
                        servertwo.ForeColor = Color.Lime;
                    }
                }
                catch (PingException e)
                {
                    servertwo.Invoke((MethodInvoker)(() => servertwo.Text = "Offline"));
                    servertwo.ForeColor = Color.Red;
                }


            Thread.Sleep(50);

                //Server 3
                try
                {
                    Ping p2 = new Ping();
                    PingReply r2;
                    r2 = p2.Send(server2);

                    if (r2.Status == IPStatus.Success)
                    {
                        serverthree.Invoke((MethodInvoker)(() => serverthree.Text = "Online " + r2.RoundtripTime.ToString() + " ms" + "\n"));
                        serverthree.ForeColor = Color.Lime;
                    }
                }
                catch (PingException e)
                {
                    serverthree.Invoke((MethodInvoker)(() => serverthree.Text = "Offline"));
                    serverthree.ForeColor = Color.Red;
                }

            Thread.Sleep(1000);

            }
        }
