﻿using System.Collections.Generic;
using System.Web.Http;
using BusinessLogicLayer;
using DataLayer.Model;

namespace ServicesLayer.ApiControllers
{
    public class SlotsController : ApiController
    {
        private IConferenceManager conferenceManager;

        public SlotsController(IConferenceManager manager)
        {
            conferenceManager = manager;
        }

        [HttpGet]
        [ActionName("list")]
        public IList<Slot> AllSlots()
        {
            return conferenceManager.AvailableSlots();
        }

        [HttpGet]
        [ActionName("breaks")]
        public IList<Slot> AllBreaks()
        {
            return conferenceManager.AvailableSlots(true);
        }

        [HttpGet]
        [ActionName("assignable")]
        public IList<Slot> AllAssignableSlots()
        {
            return conferenceManager.AvailableSlots(false);
        }

        [HttpGet]
        [ActionName("notassigned")]
        public IList<Slot> GetNotAssignedSlots()
        {
            return conferenceManager.GetNotAssignedSlots();
        }

        [HttpPut]
        [ActionName("list")]
        public void UpdateSlot(Slot slot)
        {
            conferenceManager.UpdateSlot(slot);
        }
    }
}