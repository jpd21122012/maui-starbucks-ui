using CassavaRoots.Enums;

namespace CassavaRoots.Extensions
{
    public static class ContentTypeExtensions
    {
        /// <summary>
        /// Normalizes the type of the MIME.
        /// </summary>
        /// <param name="contentType">Type of the content.</param>
        /// <returns></returns>
        public static string NormalizeMimeType(this ContentType contentType)
        {
            return contentType switch
            {
                ContentType.Json => "application/json",
                ContentType.FormUrlEncoded => "application/x-www-form-urlencoded",
                ContentType.JavaScript => "application/javascript",
                ContentType.Xml => "application/xml",
                ContentType.Zip => "application/zip",
                ContentType.ZipCompressed => "application/x-zip-compressed",
                ContentType.Pdf => "application/pdf",
                ContentType.Sql => "application/sql",
                ContentType.LdJson => "application/ld+json",
                ContentType.Mpeg => "audio/mpeg",
                ContentType.Vorbis => "audio/vorbis",
                ContentType.FormData => "multipart/form-data",
                ContentType.TxtCss => "text/css",
                ContentType.Html => "text/html",
                ContentType.Csv => "text/csv",
                ContentType.PlainText => "text/plain",
                ContentType.Png => "image/png",
                ContentType.Jpeg => "image/jpeg",
                ContentType.Jpg => "image/jpg",
                ContentType.Gif => "image/gif",
                ContentType.OctetStream => "application/octet-stream",
                ContentType.ApplicationCsv => "application/csv",
                ContentType.ApplicationVndMsExcel => "application/vnd.ms-excel",
                _ => "",
            };
        }
    }
}
