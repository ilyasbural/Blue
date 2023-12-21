namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class TypeController : Controller
	{
		readonly ITypeService Service;
		public TypeController(ITypeService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<TypeViewModel>>(new List<TypeViewModel>());
			Response<Type> TypeResponse = await Service.SelectAsync(new TypeSelectDto { });
			foreach (Type Type in TypeResponse.Collection)
			{
				TypeViewModel ViewModel = new TypeViewModel { Id = Type.Id, Name = Type.Name };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<TypeViewModel>(new TypeViewModel());
			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] TypeViewModel Model)
		{
			TypeRegisterDto Type = new TypeRegisterDto();
			Type.Name = Model.Name;
			Response<Type> Response = await Service.InsertAsync(Type);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update(Guid Id)
		{
			var Model = Tuple.Create<TypeViewModel>(new TypeViewModel());
			return View(Model);
		}

		public IActionResult Delete(Guid Id)
		{
			var Model = Tuple.Create<TypeViewModel>(new TypeViewModel());
			return View(Model);
		}
	}
}