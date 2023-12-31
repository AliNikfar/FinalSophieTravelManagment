﻿using FinalSophieTravelManagment.Domain.Events;
using FinalSophieTravelManagment.Domain.Exceptions;
using FinalSophieTravelManagment.Domain.ValueObject;
using FinalSophieTravelManagment.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSophieTravelManagment.Domain.Entities
{
    public class TravelerCheckList : AggregateRoot<TravelerCheckListId>
    {
        public TravelerCheckListId Id { get; private set; }
        private TravelerCheckListName _name { get; set; }
        private Destination _destination{ get; set; }

        private readonly LinkedList<TravelerItem> _items = new();

        internal TravelerCheckList(TravelerCheckListId id,
            TravelerCheckListName name,
            Destination destination)
        {
            Id = id;
            _name = name;
            _destination = destination;
        }

        private TravelerCheckList(TravelerCheckListId id,TravelerCheckListName name,
            Destination destination,LinkedList<TravelerItem> items)
            :this(id,name,destination)
        {
            _items = items;
        }
        public TravelerCheckList()
        {

        }
        public void AddItem(TravelerItem item)
        {
            var alreadyExists = _items.Any(i => i.Name == item.Name);
            if (alreadyExists)
                {
                    throw new TravelerItemAlReadyExistsException(_name, item.Name);
                }
            _items.AddLast(item);
            AddEvent(new TravelerItemAdded(this, item));
        }

        public void AddItems(IEnumerable<TravelerItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }
        public void TakeItem(string itemName)
        {
            var item = GetItem(itemName);
            var TravelerItem = item with { IsTaken = true };
            _items.Find(item).Value = TravelerItem;
            AddEvent(new TravelerItemTaken(this, item));
        }


        private TravelerItem GetItem(string itemName)
        {
            var item = _items.SingleOrDefault(i => i.Name == itemName);
            if (item == null)
            {
                throw new travelerItemNotFoundException(itemName);
            }
            return item;
        }
        public void RemoveItem(string itemName)
        {
            var item = GetItem(itemName);
            _items.Remove(item);
            AddEvent(new TravelerItemRemoved(this, item));
        }
    }

}
