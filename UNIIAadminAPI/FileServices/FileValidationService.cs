﻿using System.Net.Mime;
using UniiaAdmin.Data.Interfaces.FileInterfaces;
using UniiaAdmin.WebApi.Constants;

namespace UniiaAdmin.WebApi.FileServices
{
    public class FileValidationService : IFileValidationService
    {
        private readonly IFileValidatorFactory _fileValidatorFactory;

        public FileValidationService(IFileValidatorFactory fileValidatorFactory)
        {
            _fileValidatorFactory = fileValidatorFactory;
        }

        public void ValidateFile(IFormFile file, string? mediaType)
        {
            var validator = _fileValidatorFactory.GetValidator(mediaType);
            validator?.Validate(file);
        }
    }
}
