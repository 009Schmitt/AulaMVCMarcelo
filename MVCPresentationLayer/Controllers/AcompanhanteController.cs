using AutoMapper;
using BusinessLogicalLayer;
using Common;
using Metadata;
using Microsoft.AspNetCore.Mvc;
using MVCPresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Controllers
{
    public class AcompanhanteController : Controller
    {
        IMapper _mapper;
        IAcompanhanteService acompanhanteService;

        public AcompanhanteController(IMapper mapper, IAcompanhanteService srv)
        {
            this.acompanhanteService = srv;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AcompanhanteViewModel viewModel)
        {
            Acompanhante acompanhante = _mapper.Map<Acompanhante>(viewModel);

            acompanhanteService.Insert(acompanhante);

            return View();
        }

    }
}
