using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace ConfirmationWebJob
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public static void ConfirmStockCheck([QueueTrigger("stockchecks")] string message, [Blob("confirmations/{id}")] out string output)
        {
            var timestamp = message.Split()[3];
            output = $"{timestamp} stock check successfully processed";
        }
    }
}
