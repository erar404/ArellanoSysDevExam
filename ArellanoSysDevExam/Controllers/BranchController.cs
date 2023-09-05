using ArellanoSysDevExam.Data;
using ArellanoSysDevExam.Models;
using ArellanoSysDevExam.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArellanoSysDevExam.Controllers
{
    public class BranchController : Controller
    {
        private readonly ExamDbContext examDbContextBranch;

        public BranchController(ExamDbContext examDbContextBranch)
        {
            this.examDbContextBranch = examDbContextBranch;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var branches = await examDbContextBranch.Branches.ToListAsync();
            return View(branches);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBranchViewModel addBranchRequest)
        {
            var branch = new Branch()
            {
                branchid = Guid.NewGuid(),
                branchname = addBranchRequest.branchname,
                branchcode = addBranchRequest.branchcode,
                address = addBranchRequest.address,
                barangay = addBranchRequest.barangay,
                city = addBranchRequest.city,
                permitnumber = addBranchRequest.permitnumber,
                branch_manager = addBranchRequest.branch_manager,
                dateopened = addBranchRequest.dateopened,
                isactive = addBranchRequest.isactive
            };

            await examDbContextBranch.Branches.AddAsync(branch);
            await examDbContextBranch.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var branch = await examDbContextBranch.Branches.FirstOrDefaultAsync(x => x.branchid == id);

            if (branch != null)
            {
                var viewModel = new UpdateBranchViewModel()
                {
                    branchid = branch.branchid,
                    branchname = branch.branchname,
                    branchcode = branch.branchcode,
                    address = branch.address,
                    barangay = branch.barangay,
                    city = branch.city,
                    permitnumber = branch.permitnumber,
                    branch_manager = branch.branch_manager,
                    dateopened = branch.dateopened,
                    isactive = branch.isactive
                };
                return await Task.Run(() => View("View", viewModel));
            };

            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateBranchViewModel model)
        {
            var branch = await examDbContextBranch.Branches.FindAsync(model.branchid);

            if (branch.branchid != null)
            {
                branch.branchid = model.branchid;
                branch.branchname = model.branchname;
                branch.branchcode = model.branchcode;
                branch.address = model.address;
                branch.barangay = model.barangay;
                branch.city = model.city;
                branch.permitnumber = model.permitnumber;
                branch.branch_manager = model.branch_manager;
                branch.dateopened = model.dateopened;
                branch.isactive = model.isactive;

                await examDbContextBranch.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateBranchViewModel model)
        {
            var branch = await examDbContextBranch.Branches.FindAsync(model.branchid);

            if (branch != null)
            {

                examDbContextBranch.Remove(branch);
                await examDbContextBranch.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");
        }


    }
}
