using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var carToAdd = _rentalDal.Get(r=>r.CarId==rental.CarId);

            if(carToAdd.ReturnDate<DateTime.Now || carToAdd == null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRented);

            }
            else
            {
                return new ErrorResult(Messages.CarUnavailable);
            }



        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
