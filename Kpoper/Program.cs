using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Kpoper.Data;
using Kpoper.DTOs;
using Kpoper.Entities;
using System.Net.Http.Headers;

using Kpoper.Server.Mapper;
using Microsoft.AspNetCore.Mvc;




    
    //var client = new HttpClient();
    //var request = new HttpRequestMessage
    //{
    //    Method = HttpMethod.Get,
    //    RequestUri = new Uri("https://k-pop.p.rapidapi.com/idols/random"),
    //    Headers =
    //{
    //    { "x-rapidapi-key", "dfc49f9a67mshc5ebc5f88ae5491p173298jsn8a1748ca8bf3" },
    //    { "x-rapidapi-host", "k-pop.p.rapidapi.com" },
    //},
    //};

    //using (var response = await client.SendAsync(request))
    //{
        
    //    response.EnsureSuccessStatusCode();
    //    var body = await response.Content.ReadFromJsonAsync<RapidIdolDTO>();
        
    //    //ReadAsStringAsync();
    //    Console.WriteLine(body.data.FirstOrDefault().FullName);

          
    //    //context.Idols.Add(body.data.FirstOrDefault());  
    //    //Idols.Add(body.data.);
        
        

    //}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//static async Task Main(string[] args)
//{
//    Console.WriteLine("ConsoleTestApp");


    //получаем данные
    //    string url = "https://k-pop.p.rapidapi.com/"; 
    //    var service = new WebIdolsApiService(url);
    //    var idols = await service.GetIdolsAsync();

    //    Console.WriteLine($"Получены айдолы");

    //    //сохраняем данные в БД
    //    //var repository = new CarsRepository();
    //   //int result = await repository.SaveCarsAsync(cars);

    //    //Console.WriteLine($"Сохранено {result.ToString()} авто в БД");

    //    Console.ReadLine();
//}
//public async Task<ActionResult<List<Idol>>> AddIdol(Idol _idol)
//{
//    _context.Idols.Add(_idol);
//    await _context.SaveChangesAsync();

//    return Ok(await _context.Idols.ToListAsync());
//}


//}
//{ "status":"success","message":"Data fetched successfully","data":[{ "Profile":"https://dbkpop.com/idol/j-hope-bts/","Stage Name":"J-Hope","Full Name":"Jung Hoseok","Korean Name":"정호석","K. Stage Name":"제이홉","Date of Birth":"1994-02-18","Group":"BTS","Country":"South Korea","Second Country":null,"Height":"177","Weight":"65","Birthplace":"Gwangju","Other Group":null,"Former Group":null,"Gender":"M","Position":null,"Instagram":null,"Twitter":null}],"count":1}
