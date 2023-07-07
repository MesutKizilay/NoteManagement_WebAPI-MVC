using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NoteManagement.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NoteManagement.Controllers
{
	public class NotesController : Controller
	{
		string baseUrl = "http://localhost:13139/api/";
		HttpClient client;

		public NotesController()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri(baseUrl);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public async Task<IActionResult> Index()
		{
			List<NoteDto> notes = new List<NoteDto>();

			HttpResponseMessage responseMessage = await client.GetAsync("Notes/GetAll");

			if (responseMessage.IsSuccessStatusCode)
			{
				string contentString = await responseMessage.Content.ReadAsStringAsync();
				notes = JsonConvert.DeserializeObject<List<NoteDto>>(contentString);
			}
			else
			{
				Console.WriteLine("Error");
			}

			return View(notes);
		}

		public async Task<IActionResult> DeleteNote(NoteDto noteDto)
		{
			string serializeProject = JsonConvert.SerializeObject(noteDto);
			StringContent stringContent = new StringContent(serializeProject, Encoding.UTF8, "application/json");
			await client.PostAsync("Notes/deletenote", stringContent);

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult AddNote()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddNote(NoteDto noteDto)
		{
			string serializeProject = JsonConvert.SerializeObject(noteDto);
			StringContent stringContent = new StringContent(serializeProject, Encoding.UTF8, "application/json");
			await client.PostAsync("Notes/addnote", stringContent);

			return RedirectToAction("Index");
		}
	}
}