﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PinusPengger.Model
{
    public enum ReservationStatus
    {
        Booked = 0,
        CheckedIn = 1,
        CheckedOut = 2,
    }
    public class Reservation : INotifyPropertyChanged
    {
        private int _kodePemesanan;
        private Room _room;
        private Person _person;
        private DateTime? checkIn;
        private DateTime? checkOut;
        private ReservationStatus status;

        public Reservation(int kodePemesanan, Room room, Person person, DateTime? checkIn, DateTime? checkOut)
        {
            KodePemesanan = kodePemesanan;
            Room = room;
            Person = person;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int KodePemesanan
        {
            get => _kodePemesanan;
            set
            {
                _kodePemesanan = value;
                OnPropertyChanged();
            }
        }

        public Room Room
        {
            get => _room;
            set
            {
                _room = value;
                OnPropertyChanged();
            }
        }
        public Person Person
        {
            get => _person;
            set
            {
                _person = value;
                OnPropertyChanged();
            }
        }
        public DateTime? CheckIn
        {
            get => checkIn;
            set
            {
                checkIn = value;
                OnPropertyChanged();
            }
        }
        public DateTime? CheckOut
        {
            get => checkOut;
            set
            {
                checkOut = value;
                OnPropertyChanged();
            }
        }
        public ReservationStatus Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
