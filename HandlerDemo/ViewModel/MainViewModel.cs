using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace HandlerDemo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private BehaviourRequest br;

        public BehaviourRequest BR
        {
            get { return br; }
            set { br = value; RaisePropertyChanged(() => BR); }
        }


        public RelayCommand<string> ClickUP
        { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            br = new BehaviourRequest(3, "No Opreation");
               ClickUP = new RelayCommand<string>(GetTheResult);
        }
        private void GetTheResult(string str)
        {

        }
    }
}