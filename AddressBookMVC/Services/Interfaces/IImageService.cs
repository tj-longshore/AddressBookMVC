﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AddressBookMVC.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}
