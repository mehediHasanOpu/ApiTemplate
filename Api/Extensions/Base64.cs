using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Detection.Services;

namespace Api.Extensions
{
    public class Base64
    {
        private readonly IDetectionService _detectionService;
        public Base64(IDetectionService detectionService)
        {
            _detectionService = detectionService;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public string BrowserFingerprint()
        {
            var data =  _detectionService.Browser.Name +
                        Convert.ToString(_detectionService.Browser.Version) +
                        _detectionService.Crawler.Name +
                        _detectionService.Crawler.Version +
                        _detectionService.Device.Type +
                        _detectionService.Engine.Name +
                        _detectionService.Engine.Version +
                        _detectionService.Platform.Name +
                        _detectionService.Platform.Version +
                        _detectionService.Platform.Processor;
            return Base64Encode(data);
        }
    }
}
