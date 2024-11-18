using FTP_client;

FTP ftp = new("195.161.68.19", "j02458176", "178982az");
// Console.WriteLine(ftp.DownloadFile("http://183272a7c67f.hosting.myjino.ru/05%20-%20No%20One%20Left.mp3", @"C:\Users\andre\Desktop\file.mp3"));
Console.WriteLine(ftp.UploadFile(@"file.txt", @"ftp://183272a7c67f.hosting.myjino.ru/domains/183272a7c67f.hosting.myjino.ru/file.txt"));
