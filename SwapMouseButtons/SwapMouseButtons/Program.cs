namespace SwapMouseButtons
{
	internal class Program
	{
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern System.Int32 SwapMouseButton(System.Int32 bSwap);

		private static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				int rightButtonIsAlreadyPrimary = SwapMouseButton(1);
				if (rightButtonIsAlreadyPrimary != 0)
				{
					SwapMouseButton(0);  // Make the left mouse button primary
					string exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName.Replace(".vshost","");
					System.Console.WriteLine("Try \"" + exeName + " lefty\" to make left primary.\nTry \"" + exeName + " righty\" to make right primary.");
				}
			}
			else
			{
				if ((args[0].ToLower() == "leftprimary") || (args[0].ToLower() == "lefty"))
				{
					SwapMouseButton(0);  // Make the left mouse button primary
					System.Console.WriteLine("lefty");
				}
				else
				{
					if ((args[0].ToLower() == "rightprimary") || (args[0].ToLower() == "righty"))
					{
						SwapMouseButton(1);  // Make the right mouse button primary
						System.Console.WriteLine("righty");
					}
					else
					{
						string exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName.Replace(".vshost","");
						System.Console.WriteLine("Try \"" + exeName + " lefty\" to make left primary.\nTry \"" + exeName + " righty\" to make right primary.");
					}
				}
			}
		}
	}
}