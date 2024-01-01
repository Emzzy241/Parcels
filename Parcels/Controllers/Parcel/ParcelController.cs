using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System;
using System.Collections.Generic;

namespace Parcels.Controllers
{
    public class ParcelController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Parcel> myParcelsList = Parcel.GetAllParcels();
            return View(myParcelsList);
        }

        [HttpGet("/parcels/new")]
        public ActionResult New()
        {
            return View();
        }

        // View to display the parcel
        [HttpPost("/parcels")]
        public ActionResult Create(string newParcelName, string newParcelDimensions, int newParcelsWeight)
        {
            Parcel newParcel = new Parcel(newParcelName, newParcelDimensions, newParcelsWeight);

            return RedirectToAction("Index");
        }
       
        [HttpGet("/parcels/{id}")]
        public ActionResult Show(int id)
        {
           Parcel foundParcel = Parcel.FindParcel(id);

            return View(foundParcel);
        }

        [HttpGet("/parcels/delete")]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost("/parcels/deleteall")]
        public ActionResult DeleteAll()
        {
            Parcel.RemoveAllParcels();
            return RedirectToAction("Index");
        }

    }
}