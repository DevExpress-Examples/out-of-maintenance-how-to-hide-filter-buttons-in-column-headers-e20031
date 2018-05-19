using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace E20031 {
    public class TestViewModel : BindableBase {
        ObservableCollection<TestData> _records;
        public ObservableCollection<TestData> Records {
            get { return _records; }
            set {
                if (_records != value) {
                    _records = value;
                    RaisePropertyChanged(() => Records);
                }
            }
        }
        public TestViewModel() {
            Records = new ObservableCollection<TestData>();
            for (int i = 0; i < 10; i++)
                Records.Add(new TestData() { Text = "Row" + i, Number = i });
        }
    }
    public class TestData {
        public string Text { get; set; }
        public int Number { get; set; }
    }
}