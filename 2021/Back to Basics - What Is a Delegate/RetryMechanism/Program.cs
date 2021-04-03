using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RetryMechanism
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Func<Task<string>> action = () => DownloadPage("www.google.com");
            var result = await Retry(action, TimeSpan.FromSeconds(5), 3);
        }

        static async Task<string> DownloadPage(string url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync(url);

            return await result.Content.ReadAsStringAsync();
        }

        static async Task<T> Retry<T>(Func<Task<T>> action, TimeSpan retryInterval, int maxAttempt)
        {
            var exceptions = new List<Exception>();

            for (int attempted = 0; attempted < maxAttempt; attempted++)
            {
                try
                {
                    return await action();
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);

                    await Task.Delay(retryInterval);
                }
            }

            throw new AggregateException(exceptions);
        }
    }
}
