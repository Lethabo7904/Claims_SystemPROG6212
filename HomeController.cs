using System.Diagnostics;
using ClaimsSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClaimsSystem.Controllers
{
    public class ClaimsController : Controller
    {
        private static List<Claim> claims = new List<Claim>();

        // Show all claims
        public IActionResult Index()
        {
            return View(claims);
        }

        // Lecturer submits new claim
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Claim claim)
        {
            claim.Id = claims.Count + 1;
            claims.Add(claim);
            return RedirectToAction("Index");
        }

        // Coordinator/Manager approves claim
        public IActionResult Approve(int id)
        {
            var claim = claims.FirstOrDefault(c => c.Id == id);
            if (claim != null)
                claim.Status = ClaimStatus.Approved;

            return RedirectToAction("Index");
        }

        // Coordinator/Manager rejects claim
        public IActionResult Reject(int id)
        {
            var claim = claims.FirstOrDefault(c => c.Id == id);
            if (claim != null)
                claim.Status = ClaimStatus.Rejected;

            return RedirectToAction("Index");
        }
    }
}