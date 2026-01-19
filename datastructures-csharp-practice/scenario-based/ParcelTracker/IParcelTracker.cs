using System;

namespace ParcelTrackerApp
{
    interface IParcelTracker
    {
        void AddStage(string StageName);
        void AddCheckpointAfter(string ExistingStage, string NewStage);
        void TrackParcel();
    }
}