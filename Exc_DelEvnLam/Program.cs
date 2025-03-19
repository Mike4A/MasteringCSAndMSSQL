using Exc_DelEvnLam;

Exc_DelEvnLam.TaskScheduler scheduler = new Exc_DelEvnLam.TaskScheduler();
//Lambda passes anonymous funtion as delegate for the eventhandler
scheduler.TaskCompleted += (sender, result) => Console.WriteLine($"Task completed: {result}");
scheduler.ExecuteTask(() => "Hello, World!"); 
scheduler.ExecuteTask(() => DateTime.Now.ToString()); 