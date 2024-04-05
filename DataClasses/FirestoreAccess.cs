using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LOGIN.DataClasses
{
    internal static class FirestoreAccess
    {
        static string fireConfig = @"
        {
          ""type"": ""service_account"",
          ""project_id"": ""login-signup-system-eb9a0"",
          ""private_key_id"": ""e650f9d8a2925efeefbca89432c0a22390773154"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQDD2LsF0UD/1QKg\nTKhBfpQJvRtoBvn2VIguR5bnszvOOTluHlXDAEEDeomAN5iGhMznT5PNp9lmhsS2\nm5eyPGV4GvxL5YGQNK2LgukuSCBX4ZJI/DlSwpgrSmWH1wcpZweaHYrYXYJfEiYr\nDOCqggep7rbrnIg9GEApB1hDK5ZX7/x7El3NBPGP4KFWS4/T3L5cLnD7cUt5Uex8\niz8Qwp8F+U2S/MpgbMmhK38aVWxzA0Pf2F0Ds78JG+f7+0WroS8UfXfvx7mBGlvK\nu0NwofJezPrPah3IFGgF42QBVbSLDjVpvHaWzHQdH+cmxIKDTCaLsqwjWv2a+HZ8\nDwR1vzYLAgMBAAECggEAA+CbF0rkyAveEPFjlWRdpvG1BLK6qStUROJK9Qxh3zvX\nzLvSA9nR77Ex3rV7EhK4Ac5cBULQ9YwugdUDxFYYxi92lkQVdBbu5qexWSa5aTQA\nkuxXcDGFFLpU10MlE6dECcOS96SmS56O3eRT4FxRrYYZ3gFL2zXLM2S/VRkcUWJY\nhCV0n+S9mLe9S2JsJvMtMO5iuRRttx/Lm3QQ3lB98k9NDd/+4VY75p55X2sjWKoO\nRD0W5u/PsVvrCKU4JAe+Wk90mzK4rLQ01AhoAABTR4bKqmOly6Uf1ntp9g1h0cwK\nH14hHHEB2tF7aQenfMBDwUdckQnZnvzaGkYek3Fs7QKBgQD94rQjJob7qSUplkWq\ncOfGGHTR8sIOU/teanHtYKMByvEnrMmzIf+wQXjeKh6+irhA9wh6pR71v5rJGt5f\n1Ot+mk6QAGLdCbG7WqgxQ6khZwZbX9zcMjWUf2R6IbGdLUOZuGa3N0B2MZvrikGA\nwXZ7vt71L3bhVDzPYgUzBo7AbQKBgQDFekj3M+LIuiyeTFxn7WX/DNweZkZQeJkA\nD/45pARVv197MqT7jk+ndetBkFKLnaIiUjMyw9qbFbDKUpxMfET0PXOur+WHDJfG\nkZHU1TTwK8BFbhvelJqQICUNsNAEMVPZEnTs76cpQyZql3fB2Y9T4TmNozX1oxNv\nPYJNCDJ1VwKBgAtyjGLFWvK/9rAAWZXMz3aMJcBNrNhOixf/vrFQWSk8iFEcpl+Q\nWeINobCKv6YhxRsQyG4XQeUcxZLpxjsV86Raus4dZlfHFx92f/zwqxCZf5zhHqlD\nDk1qzRIAsOyAXPryaJc8Q4jQxdICAuAWWQxNV+pAQKD6Vl+XcNqTIh6lAoGADIdr\npbN3CgE13308x6M6O2pXdN5MS8K7AlQBbyrG06HmruxRp1wqFZfXqzs64XzI0qCg\nevIOJpTDuLJxFDE2NsDHXCfwyha0cna95+D3EN3VvxHzVrXa8JX5g9rZ98ohZb5U\nCMxTsLx/7Xdas8PX4hyCCEh4nfMQwpgGcli4ytUCgYEAsH76h56cQ32kHrT3S86B\n9SFHdbNhQmZSl70ln1J1NmbxAobOFnC47sayrcNtGgAipSUJ9wR+jOFjL6mqoljS\nQPR8X9UDgM2wmR6tx8KoYwuqvEGW2D/WSnx0v7fYkFjrFqxgfYZaW2rZch3fllj1\nmW1HSRFXXh33PyIvLyAFGss=\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-1k53w@login-signup-system-eb9a0.iam.gserviceaccount.com"",
          ""client_id"": ""109295266325751646982"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-1k53w%40login-signup-system-eb9a0.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }";

        static string filePath = "";
        public static FirestoreDb? Database { get; private set;  }

        public static void SetEnvironmentVariable()
        {
            filePath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filePath, fireConfig);
            File.SetAttributes(filePath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);

            Database = FirestoreDb.Create("login-signup-system-eb9a0");

            File.Delete(filePath);
        }
    }
}
