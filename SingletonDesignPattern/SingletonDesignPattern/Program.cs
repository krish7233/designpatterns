internal class Program
{
    public class SingletonDP { 
        private static SingletonDP instance = null;
        private static readonly object _object = new object();

        private SingletonDP() { }

        public static SingletonDP GetInstance()
        {
            if (instance == null)
            {
                lock (_object)
                {
                    if(instance == null)
                    {
                        instance = new SingletonDP ();
                    }
                }
            }

            return instance;
        }
    }
    private static void Main(string[] args)
    {
        Thread[] threads = new Thread[10];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                var instnace = SingletonDP.GetInstance();

                Console.WriteLine($"instance hash code: {instnace.GetHashCode()}");
            });

            threads[i].Start();
        }

        for(int i = 0;i < threads.Length; i++)
        {
            threads[i].Join();
        }

        Console.WriteLine("Hello, World!");
    }
}