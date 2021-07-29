using CalculatorWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Services
{
    public interface IHistoryService
    {
        IEnumerable<History> GetAll();
        History GetById(int id);
        IEnumerable<History> GetByUser(int userId);
        History Create(History story);
        void Update(int id, History story);
        void Delete(int id);
    }
    public class HistoryService : IHistoryService
    {
        private CalculateContext _context;

        public HistoryService(CalculateContext context)
        {
            _context = context;
        }
        public History Create(History story)
        {
            _context.Histories.Add(story);
            _context.SaveChanges();

            return story;
        }

        public void Delete(int id)
        {
            var model = _context.Histories.Find(id);
            if (model != null)
            {
                _context.Histories.Remove(model);
                _context.SaveChanges();
            }
        }

        public IEnumerable<History> GetAll()
        {
            return _context.Histories;
        }

        public IEnumerable<History> GetByUser(int userId)
        {
            return _context.Histories.Where(p => p.UserId == userId).ToList();
        }

        public History GetById(int id)
        {
            return _context.Histories.Find(id);
        }

        public void Update(int id, History story)
        {
            var res = _context.Histories.Find(id);
            if (res != null)
            {
                _context.Histories.Update(story);
                _context.SaveChanges();
            }
        }
    }
}
