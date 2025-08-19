using System.Runtime.Serialization;

namespace HarmonicModels
{

    [DataContract]
    public class MajorScaleModel
    {

        [DataMember]
        public float tonic { get; }

        [DataMember]
        public float supertonic { get; }

        [DataMember]
        public float mediant { get; }

        [DataMember]
        public float subdminant { get; }

        [DataMember]
        public float dominant { get; }

        [DataMember]
        public float submediant { get; }

        [DataMember]
        public float leading { get; }

        [DataMember]
        public float oct { get; }

        public MajorScaleModel()
        {

            tonic = 0;
            supertonic = 1f;
            mediant = 0.5f;
            subdminant = 1f;
            dominant = 1f;            
            leading = 1f;
            oct = 0.5f;

        }

    }
}
