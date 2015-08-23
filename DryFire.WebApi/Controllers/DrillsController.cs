using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using DryFire.DataLayer;
using DryFire.DomainClasses;

namespace DryFire.WebApi.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using DryFire.DomainClasses;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Drill>("Drills");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class DrillsController : ODataController
    {
        private DryFireContext db = new DryFireContext();

        // GET: odata/Drills
        [EnableQuery]
        public IQueryable<Drill> GetDrills()
        {
            return db.Drills;
        }

        // GET: odata/Drills(5)
        [EnableQuery]
        public SingleResult<Drill> GetDrill([FromODataUri] int key)
        {
            return SingleResult.Create(db.Drills.Where(drill => drill.DrillId == key));
        }

        // PUT: odata/Drills(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Drill> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Drill drill = await db.Drills.FindAsync(key);
            if (drill == null)
            {
                return NotFound();
            }

            patch.Put(drill);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrillExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(drill);
        }

        // POST: odata/Drills
        public async Task<IHttpActionResult> Post(Drill drill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Drills.Add(drill);
            await db.SaveChangesAsync();

            return Created(drill);
        }

        // PATCH: odata/Drills(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Drill> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Drill drill = await db.Drills.FindAsync(key);
            if (drill == null)
            {
                return NotFound();
            }

            patch.Patch(drill);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrillExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(drill);
        }

        // DELETE: odata/Drills(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            Drill drill = await db.Drills.FindAsync(key);
            if (drill == null)
            {
                return NotFound();
            }

            db.Drills.Remove(drill);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DrillExists(int key)
        {
            return db.Drills.Count(e => e.DrillId == key) > 0;
        }
    }
}
