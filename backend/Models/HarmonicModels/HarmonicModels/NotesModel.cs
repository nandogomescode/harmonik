using System.Runtime.Serialization;

namespace HarmonicModels
{

    [DataContract]
    public class NotesModel
    {

        [DataMember]
        public float C { get; }

        [DataMember]
        public float Cs { get; }

        [DataMember]
        public float D { get; }

        [DataMember]
        public float Ds { get; }

        [DataMember]
        public float E { get; }

        [DataMember]
        public float F { get; }

        [DataMember]
        public float Fs { get; }

        [DataMember]
        public float G { get; }

        [DataMember]
        public float Gs { get; }

        [DataMember]
        public float A { get; }

        [DataMember]
        public float As { get; }

        [DataMember]
        public float B { get; }

        public NotesModel()
        {

            C = 0.5f;
            Cs = 0.5f;
            D = 0.5f;
            Ds = 0.5f;
            E = 0.5f;
            F = 0.5f;
            Fs = 0.5f;
            G = 0.5f;
            Gs = 0.5f;
            A = 0.5f;
            As = 0.5f;
            B = 0.5f;
        }
    }
}
