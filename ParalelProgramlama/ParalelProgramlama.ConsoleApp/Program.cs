

namespace ParalelProgramlama.ConsoleApp;

internal class Program
{
    private static readonly object lockObj = new();
    private static int count = 0;
    private static Mutex mutex = new();
    private static Semaphore semaphore = new(2,2);
    static void Main(string[] args)
    {
        //15:03 görüşelim
        //Task ve Parallel Sınıflar
        //TaskMetot();
        //ParallelMetot();
        //IsParcacigiYonetimiMetot();

        for (int i = 0; i < 5; i++)
        {
            Thread thread = new Thread(AccessResource)
            {
                Name = "Thread" + i
            };
            thread.Start();
        }

    }

    private static void AccessResource()
    {
        semaphore.WaitOne();

        Console.WriteLine("Kaynağa erişiliyor: " + Thread.CurrentThread.Name);
        Thread.Sleep(1000);

        semaphore.Release();
    }

    private static void AccessDatabase()
    {
        mutex.WaitOne();

        Console.WriteLine("Database bağlantısı başlatıldı: " + Thread.CurrentThread.Name);
        Thread.Sleep(1000);

        mutex.ReleaseMutex();
    }

    private static void Execute()
    {
        Monitor.Enter(lockObj);
        try
        {
            Console.WriteLine("Kiritik bölge");
            Thread.Sleep(1000);
        }
        finally
        {
            Monitor.Exit(lockObj);  
            
            //3. Metot
        }
    }

    private static void IncrementCount()
    {
        lock (lockObj)
        {
            count++;
            Console.WriteLine("Mevcut sayı: " + count);
        }
    }

    private static void IsParcacigiYonetimiMetot()
    {
        Thread yeniThread = new(new ThreadStart(IsParcacigiMetodu));

        yeniThread.Priority = ThreadPriority.Lowest;

        yeniThread.Start();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ana iş parçacığı çalışıyor");
            Thread.Sleep(500);
        }

        Console.WriteLine("Ana iş parçacığı tamamlandı.");
    }

    private static void IsParcacigiMetodu()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Yeni iş parçacığı çalışıyor.");
            Thread.Sleep(1000);
        }
    }

    private static void ParallelMetot()
    {
        Parallel.For(0, 10, i =>
        {
            Console.WriteLine($"Paralel döngü iterasyonu: {i}");
            Thread.Sleep(1000);
        });

        //Parallel.Invoke(
        //    () => Metot1(),
        //    () => Metot2()
        //    );

        Console.WriteLine("Paralel döngü tamamlandı");
    }

    private static void Metot2()
    {
        Console.WriteLine("Metot 2 çalışıyor");
        Thread.Sleep(2000);
    }

    private static void Metot1()
    {
        Console.WriteLine("Metot 1 çalışıyor");
        Thread.Sleep(3000);
    }

    private static void TaskMetot()
    {
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Sayılan sayı: {i}");
                Thread.Sleep(1000);
            }
        });

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Sayılan sayı: {i}");
            Thread.Sleep(1000);
        }

        task.Wait();

        Console.WriteLine("Task dahil sayma tamamlandı!");
    }
}
