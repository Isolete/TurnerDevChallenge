using System.Runtime.Serialization;

namespace TurnerDevChallenge.Data.ViewModels
{
    public abstract class ViewModelBase : IViewModelBase
    {
        [DataMember]
        public int Id { get; set; }
    }
}
