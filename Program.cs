using System;

namespace MyprojecsApp
{
    class Program
    {
        const string pro = "0000";
        const string exp = "0001";
        static void Main(string[] args)
        {/*
                                             //Задача 1
            Console.WriteLine("Вводите ключь лицензии: ");
            string License = Console.ReadLine();

            DocumentWorker worker;
            switch (License)
            {
                case pro: worker = new ProDocumentWorker(); break;
                case exp: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }

            while (true)
            {
                Console.WriteLine("Введите команду(O/E/S/Exit): ");
                switch (Console.ReadLine())
                {
                    case "O": worker.OpenDocument(); break;
                    case "E": worker.EditDocument(); break;
                    case "S": worker.SaveDocument(); break;
                    case "Exit": return;
                }
            }


                                        //Задача 2

            IPlayable Track_1 = new Player();
            IRecodable Track_2= new Player();
            Track_1.Play();
            Track_1.Pause();
            Track_1.Stop();

            Track_2.Record();
            Track_2.Pause();
            Track_2.Stop();

            Console.ReadKey();*/
        }
    }
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    interface IPlayable

    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable

    {
        void Record();
        void Pause();
        void Stop();
    }

    public class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play melody");
        }

        public void Pause()
        {
            Console.WriteLine("Pause melody");
        }

        public void Stop()
        {
            Console.WriteLine("Stop melody");
        }
        public void Record()
        {
            Console.WriteLine("Record melody");
        }
    }
}
