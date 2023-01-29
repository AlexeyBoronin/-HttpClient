using static System.Console;

//1. public HttpClient(System.Net.Http.HttpMessageHandler handler);
//2. public HttpClient(System.Net.Http.HttpMessageHandler handler, bool disposeHandler);
//3. public HttpClient();=>HttpClient(new HttpClientHandler(),true)
/*class Program
{
    static HttpClient client1 = new HttpClient();
    static async Task Main(string[] args)
    {
        HttpMessageHandler handler1 = new HttpClientHandler();
        WriteLine("Запуск программы");
        for (int i = 0; i < 10; i++)
        {
           
            {
                var result1 = await client1.GetAsync("https://google.com");
                WriteLine(result1.StatusCode);
            }
        }
        WriteLine("Приложение завершило работу");
    }
}*/
/*class Program
{
    static HttpClient? httpClient1;

    static async Task Main(string[] args)
    {
        var socketHandler1 = new SocketsHttpHandler
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(2)
        };
        httpClient1 = new HttpClient(socketHandler1);

        WriteLine("Запуск программы");
        for (int i = 0; i < 10; i++)
        {

            
                var result1 = await httpClient1.GetAsync("https://google.com");
                WriteLine(result1.StatusCode);
            
        }
        WriteLine("Приложение завершило работу");
    }
}*/
/*using Microsoft.Extensions.DependencyInjection;

//определяем коллекцию сервисов
var services1 = new ServiceCollection();
//добавляем сервисы, связанные с HttpClient, в том числе IHttpClientFactory
services1.AddHttpClient();
//создаем провайдер сервисов
var serviceProvider1 = services1.BuildServiceProvider();
//получаем сервис IHttpClientFactory
var httpClientFactory1 = serviceProvider1.GetService<IHttpClientFactory>();
//Создаем объект HttpClient
var httpClient1 = httpClientFactory1.CreateClient();
WriteLine("Запуск программы");
for (int i = 0; i < 10; i++)
{


    var result1 = await httpClient1.GetAsync("https://google.com");
    WriteLine(result1.StatusCode);

}
WriteLine("Приложение завершило работу");*/
//Отправка запросов с помощью HttpClient
//Отправка запроса методом SendAsync
/*class Program
{
    static HttpClient httpClient1 = new HttpClient();

    static async Task Main()
    {
        //оперделяем данные запроса
        using HttpRequestMessage request1 = new HttpRequestMessage(HttpMethod.Get, "https://www.google.com");
        //выполняем запрос
        await httpClient1.SendAsync(request1);
    }
}*/
//Получение ответа
/*class Program
{
    static HttpClient httpClient1 = new HttpClient();

    static async Task Main()
    {
        //определяем данные запроса
        using HttpRequestMessage request1 = new HttpRequestMessage(HttpMethod.Get, "https://mail.ru/");
        //получаем ответ
        using HttpResponseMessage response1 = await httpClient1.SendAsync(request1);
        //Просматриваем данные ответа
        //статус
        WriteLine($"Status: {response1.StatusCode}\n");
        //Заголовки
        WriteLine("Headers");
        foreach(var header1 in response1.Headers)
        {
            Write($"{header1.Key}");
            foreach(var headerValue1 in header1.Value)
            {
                WriteLine(headerValue1);
            }
        }
        //Содержимое ответа
        WriteLine("\nContent");
        string content1 = await response1.Content.ReadAsStringAsync();
        WriteLine(content1);
    }
}*/
//GetAsync()
/*class Program
{
    static HttpClient httpClient1 = new HttpClient();
    static async Task Main()
    {
        //получаем ответ
        using HttpResponseMessage response1 = await httpClient1.GetAsync("https://www.mail.com");
        //получаем ответ
        string content1 = await response1.Content.ReadAsStringAsync();
        WriteLine(content1);
    }
}*/
//GetStringAsync/GetArrayAsync/GetStreamAsync
/*class Program
{
    static HttpClient httpClient1 = new HttpClient();
    static async Task Main()
    { 
        byte[] content1 = await httpClient1.GetByteArrayAsync("https://www.mail.com");
        WriteLine(System.Text.Encoding.UTF8.GetString(content1));
    }
}*/

/*class Program
{
    static HttpClient httpClient1 = new HttpClient();
    static async Task Main()
    {
        using Stream stream1 = await httpClient1.GetStreamAsync("https://www.mail.com");
        StreamReader reader1 = new StreamReader(stream1);
        string content1 = await reader1.ReadToEndAsync();
        WriteLine(content1);
    }
}*/
WriteLine("arg.Length", args.Length);
for(int i=0;i<args.Length;i++)
{
    WriteLine("args[{0}]={1}", i, args[i]);
}

