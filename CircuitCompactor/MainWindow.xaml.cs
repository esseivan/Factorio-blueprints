using BlueprintLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace CircuitCompactor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			txtEncoded.Text = "0eNrtV9tugzAMfZ+0f0B5ptNIoLTV/mSqEJd0s1QSFEI1VPHvCwFWLt2lFataVJ7A58R2bB+i7B8fDAMF24wmAphEK2NfWpQNQs5S9f1afRsNoMEU3pi/PbBrs8wTqowIJI2R2YGYH2sooiFEVMxCHgfAfMkFOvCK1hoELKIfaonV2IrqZV2TEGUSJNBvk9R47rEsDqgoHbW9/5BPm5bwVMXgbLBVndnC6m4yV0Ziu0/ON1uKQNCwdofbgKq1FHzrBfTd3wEXg3B1mp4iRjqhtE9RpA2IVHrHe9Ppzw6EzBTHHDCaslROZg7qMoreijLxVPp6cJ6HWJz4QpdUeXxBQzzJ1YYyJr2N4LEHLMlKR1JktE0tWtX8mgXzLx3HF+r4fDodt66t472isaqcg2IgfKQ8gkbtn0PzDMp0GB0oFxDzCCEEEWYgK4bVJxTmqUHsM4J0DetxRELGFwmZuEjwrYrEGk8k+Nf5xSfNr/lfarZHTvRsodnjC82ZuNDIXWi3IzRyRqInH5vOtRybzvhqdieuZvuu5oucRr17sr6Nr9q3/AbZUZHW87OwbHeJXbzExCLzElduik+3M22a";
		}

		private void Decode_Click(object sender, RoutedEventArgs e)
		{
			if (txtEncoded.Text == string.Empty) return;
			txtDecoded.Text = BlueprintCoding.GetPrettyJson(BlueprintCoding.Decode(txtEncoded.Text, out _));
		}

		private void Encode_Click(object sender, RoutedEventArgs e)
		{
			if (txtDecoded.Text == string.Empty) return;
			txtEncoded.Text = BlueprintCoding.Encode(txtDecoded.Text, '0');
		}

		private void Compact_Click(object sender, RoutedEventArgs e)
		{
			if (txtDecoded.Text == string.Empty) return;

			Blueprint bp = Blueprint.CreateFromJson(txtDecoded.Text, '0');
			bp.Compress();
			txtDecoded.Text = BlueprintCoding.GetJson(bp.doc);
			txtEncoded.Text = BlueprintCoding.Encode(txtDecoded.Text, '0');
		}
	}
}
