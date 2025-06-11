string path = "D:\\Projects"; // Replace with your directory path

PathControl pathControl = new PathControl();
pathControl.PathControlEvent += (double fileSize) => Console.WriteLine($"Path size exceeded 10 MB! File size: {fileSize}");
await pathControl.Control(path); // Replace with your directory path

public class PathControl
{
    public delegate void PathHandler(double fileSize);
    public event PathHandler PathControlEvent;

    public async Task Control(string path)
    {
        while (true)
        {
            // Simulate some asynchronous operation
            await Task.Delay(1000);

            DirectoryInfo directoryInfo = new(path);
            var files = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
            var size = await Task.Run(() => files.Sum(file => file.Length));
            var sizeInMb = size / (1024.0 * 1024.0);

            if (sizeInMb > 10)
            {
                // If the size exceeds 10 MB, invoke the event
                PathControlEvent?.Invoke(sizeInMb); ;
            }

        }
    }
}