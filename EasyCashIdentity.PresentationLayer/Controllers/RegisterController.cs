using EasyCashIdentity.DTOLayer.Dtos.AppUserDtos;
using EasyCashIdentity.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;

namespace EasyCashIdentity.PresentationLayer.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]


		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
		{
			if(ModelState.IsValid)
			{
				Random random = new Random();
				int code;
				code = random.Next(100000, 1000000);
				AppUser appUser = new AppUser()
				{
					UserName = appUserRegisterDto.Username,
					Name = appUserRegisterDto.Name,
					Surname = appUserRegisterDto.Surname,
					Email = appUserRegisterDto.Email,
					City = "Omer",
					District = "dfdsf",
					ImageUrl = "dffgfg",
					ConfirmCode = code

				};
				var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);
				if (result.Succeeded)
				{
					MimeMessage mimeMessage = new MimeMessage();
					MailboxAddress mailboxAddressForm = new MailboxAddress("Easy Cash Admin" , "ohaydar.arpaci@std.hku.edu.tr");
					MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);


					mimeMessage.From.Add(mailboxAddressForm);
					mimeMessage.To.Add(mailboxAddressTo);

					var bodyBuilder = new BodyBuilder();
					bodyBuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz: " + code;
					mimeMessage.Body = bodyBuilder.ToMessageBody();

					mimeMessage.Subject = "Easy Cash Onay Kodu";


					SmtpClient client = new SmtpClient();
					client.Connect("smtp.gmail.com",587,false);
					client.Authenticate("ohaydar.arpaci@std.hku.edu.tr", "");
					client.Send(mimeMessage);
					client.Disconnect(true);



					return RedirectToAction("Index", "ConfirmMail");
				}
				else
				{
					foreach(var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View();
		}
	}
}
