#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Epicalyx_Game_Reviews.Models;

namespace Epicalyx_Game_Reviews.Views
{
    public class AspectReviewsController : Controller
    {
        private readonly Epicalyx_Game_ReviewsContextDb _context;

        public AspectReviewsController(Epicalyx_Game_ReviewsContextDb context)
        {
            _context = context;
        }

        // GET: AspectReviews
        public async Task<IActionResult> Index()
        {
            var epicalyx_Game_ReviewsContextDb = _context.AspectReview.Include(a => a.Game).Include(a => a.User);
            return View(await epicalyx_Game_ReviewsContextDb.ToListAsync());
        }

        // GET: AspectReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspectReview = await _context.AspectReview
                .Include(a => a.Game)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.AspectReviewID == id);
            if (aspectReview == null)
            {
                return NotFound();
            }

            return View(aspectReview);
        }

        // GET: AspectReviews/Create
        public IActionResult Create()
        {
            ViewData["GameID"] = new SelectList(_context.Game, "GameID", "AgeRating");
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserID", "UserID");
            return View();
        }

        // POST: AspectReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AspectReviewID,StoryRating,SoundtrackRating,GraphicsRating,GameplayRating,MultiplayerRating,StoryCompletion,TotalCompletion,UserID,GameID")] AspectReview aspectReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aspectReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameID"] = new SelectList(_context.Game, "GameID", "AgeRating", aspectReview.GameID);
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserID", "UserID", aspectReview.UserID);
            return View(aspectReview);
        }

        // GET: AspectReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspectReview = await _context.AspectReview.FindAsync(id);
            if (aspectReview == null)
            {
                return NotFound();
            }
            ViewData["GameID"] = new SelectList(_context.Game, "GameID", "AgeRating", aspectReview.GameID);
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserID", "UserID", aspectReview.UserID);
            return View(aspectReview);
        }

        // POST: AspectReviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AspectReviewID,StoryRating,SoundtrackRating,GraphicsRating,GameplayRating,MultiplayerRating,StoryCompletion,TotalCompletion,UserID,GameID")] AspectReview aspectReview)
        {
            if (id != aspectReview.AspectReviewID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aspectReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspectReviewExists(aspectReview.AspectReviewID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameID"] = new SelectList(_context.Game, "GameID", "AgeRating", aspectReview.GameID);
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "UserID", "UserID", aspectReview.UserID);
            return View(aspectReview);
        }

        // GET: AspectReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aspectReview = await _context.AspectReview
                .Include(a => a.Game)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.AspectReviewID == id);
            if (aspectReview == null)
            {
                return NotFound();
            }

            return View(aspectReview);
        }

        // POST: AspectReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aspectReview = await _context.AspectReview.FindAsync(id);
            _context.AspectReview.Remove(aspectReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AspectReviewExists(int id)
        {
            return _context.AspectReview.Any(e => e.AspectReviewID == id);
        }
    }
}
