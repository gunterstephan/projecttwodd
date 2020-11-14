using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projecttwodd.Models;

namespace projecttwodd.Controllers
{
    public class IndividualsController : Controller
    {
        private readonly IndividualContext _context;

        public IndividualsController(IndividualContext context)
        {
            _context = context;
        }

        // GET: Individuals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Individuals.ToListAsync());
        }

        // GET: Individuals/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
            {
                return View(new Individual());
            }
            else
            {
                return View(_context.Individuals.Find(id));
            }

        }


        // POST: Individuals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("IndivId,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRaate,NCompaniesWorked,OverEighteen,Overtime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrentManager")] Individual individual)
        {
            if (ModelState.IsValid)
            {
                _context.Add(individual);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(individual);
        }

        // GET: Individuals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var individual = await _context.Individuals
                .FirstOrDefaultAsync(m => m.IndivId == id);
            if (individual == null)
            {
                return NotFound();
            }

            return View(individual);
        }

        // POST: Individuals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var individual = await _context.Individuals.FindAsync(id);
            _context.Individuals.Remove(individual);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndividualExists(int id)
        {
            return _context.Individuals.Any(e => e.IndivId == id);
        }
    }
}
