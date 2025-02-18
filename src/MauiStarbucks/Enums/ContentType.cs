using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassavaRoots.Enums
{
    /// <summary>Content-Type</summary>
    public enum ContentType
    {
        /// <summary>application/json</summary>
        Json,
        /// <summary>application/x-www-form-urlencoded</summary>
        FormUrlEncoded,
        /// <summary>application/javascript</summary>
        JavaScript,
        /// <summary>application/xml</summary>
        Xml,
        /// <summary>application/zip</summary>
        Zip,
        /// <summary>application/x-zip-compressed</summary>
        ZipCompressed,
        /// <summary>application/pdf</summary>
        Pdf,
        /// <summary>application/sql</summary>
        Sql,
        /// <summary>application/ld+json</summary>
        LdJson,
        /// <summary>audio/mpeg</summary>
        Mpeg,
        /// <summary>audio/vorbis</summary>
        Vorbis,
        /// <summary>multipart/form-data</summary>
        FormData,
        /// <summary>text/css</summary>
        TxtCss,
        /// <summary>text/html</summary>
        Html,
        /// <summary>text/csv</summary>
        Csv,
        /// <summary>text/plain</summary>
        PlainText,
        /// <summary>image/png</summary>
        Png,
        /// <summary>image/jpeg</summary>
        Jpeg,
        /// <summary>image/jpg</summary>
        Jpg,
        /// <summary>image/gif</summary>
        Gif,
        /// <summary>application/octet-stream</summary>
        OctetStream,
        /// <summary>application/csv</summary>
        ApplicationCsv,
        /// <summary>application/vnd.ms-excel</summary>
        ApplicationVndMsExcel,
    }
}
