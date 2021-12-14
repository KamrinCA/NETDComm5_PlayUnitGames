/* Author: Kamrin Aubin:
 * Last Modified: December 13, 2021
 * Description: Helper class, will be used to set up the identity framework database tables.
 *              Also, sets up the other 3 tables required for the lab using DbSets
 * 
 */

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

// Imported the models to get access to VideoGame, VideoGameConsole, and Stores
using NETDComm5.Models;

namespace NETDComm5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Helps us run a command to take care of CRUD operations for all models (VideoGame, VideoGameConsole, Store)
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<VideoGameConsole> VideoGameConsole { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
