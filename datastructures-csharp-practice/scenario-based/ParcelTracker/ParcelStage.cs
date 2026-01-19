using System;

namespace ParcelTrackerApp
{
    public class ParcelStage
    {
        private string StageName;
        private ParcelStage Next;

        public ParcelStage(string StageName)
        {
            this.StageName = StageName;
            this.Next = null;
        }

        public string GetStageName()
        {
            return StageName;
        }

        public ParcelStage GetNext()
        {
            return Next;
        }

        public void SetNext(ParcelStage Next)
        {
            this.Next = Next;
        }
    }
}