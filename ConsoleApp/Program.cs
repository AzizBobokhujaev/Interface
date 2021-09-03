using System;
namespace ProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            Player player = new Player();
            player.PlayablePlay();
            player.PlayablePause();
            player.PlayablePause();
            Console.WriteLine();
            player.RecordableRecord();
            player.RecordablePause();
            player.RecordableStop();
            
        }
        public static void Play(IRecPlayable player)
        {
            

        }
    }
    interface IPlayable
    {
        void PlayablePlay();
        void PlayablePause();
        void PlayableStop();
    }
    interface IRecordable
    {
        void RecordableRecord();
        void RecordablePause();
        void RecordableStop();
    }
    interface IRecPlayable : IRecordable, IPlayable
    {
    }
    class Player : IRecPlayable
    {
       

        public void PlayablePause()
        {
            Console.WriteLine("PlayablePause");
        }

        public void PlayablePlay()
        {
            Console.WriteLine("PlayablePlay");
        }

        public void PlayableStop()
        {
            Console.WriteLine("PlayableStop");
        }

        
        public void RecordablePause()
        {
            Console.WriteLine("RecordablePause");
        }

        public void RecordableRecord()
        {
            Console.WriteLine("RecordableRecord");
        }

        public void RecordableStop()
        {
            Console.WriteLine("RecordableStop");
        }

    }

}