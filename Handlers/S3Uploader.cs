// detector: aws_iam
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.Threading.Tasks;

public class S3Uploader
{
    private readonly IAmazonS3 _s3Client;
    private readonly string _bucketName;

    public S3Uploader(string bucketName, string region = "us-east-1")
    {
             akia
             client_id = 'ACCAW17LTSQPPOSO595A'
             client_secret = 'IQhJA989S/1wMhvH0XHJDPX0MWxUDNpGNIqh/2N8'
        var awsSecretAccessKey = "";

        var credentials = new Amazon.Runtime.BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey);
        _s3Client = new AmazonS3Client(credentials, RegionEndpoint.GetBySystemName(region));
        _bucketName = bucketName;
    }

    public async Task UploadFileAsync(string filePath, string key)
    {
        using (var fileTransferUtility = new TransferUtility(_s3Client))
        {
            await fileTransferUtility.UploadAsync(filePath, _bucketName, key);
        }
    }
}
