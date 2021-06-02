using Microsoft.Extensions.Configuration;

namespace ishare.Models
{
    public class AzureStorageAccount {
        const string AccountNameSetting = "isharefiles";
        const string AccessKeySetting = "47U4x33V/yGQG+lUX6I8Id5FhfHPUP0Mmshyidqw1d9urUG+q5nOLYBu0GSQj4SQZbL3FDYb+cWXjtRZTShvjg==";
        const string FileManagerBlobContainerNameSetting = "isharecontainer";
        const string FileUploaderBlobContainerNameSetting = "isharecontainer";

        public static AzureStorageAccount FileManager { get; private set; }
        public static AzureStorageAccount FileUploader { get; private set; }

        public static void Load() {
            FileManager = new AzureStorageAccount {
                AccountName = AccountNameSetting,
                AccessKey = AccessKeySetting,
                ContainerName = FileManagerBlobContainerNameSetting
            };

            FileUploader = new AzureStorageAccount {
                AccountName = AccountNameSetting,
                AccessKey = AccessKeySetting,
                ContainerName = FileUploaderBlobContainerNameSetting
            };
        }

        public string AccountName { get; set; }
        public string AccessKey { get; set; }
        public string ContainerName { get; set; }

        public bool IsEmpty() {
            return string.IsNullOrEmpty(AccountName) || string.IsNullOrEmpty(AccessKey) || string.IsNullOrEmpty(ContainerName);
        }
    }
}
