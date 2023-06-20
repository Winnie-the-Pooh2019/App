using System.Collections.Generic;
using System.Linq;
using App.core.data.models;

namespace App.core.data.repo; 

public class WindRepository {
    private DataApplicationContext _context;
    
    public WindRepository(DataApplicationContext context) {
        this._context = context;
    }

    public List<WindSpeed> getAll() {
        return _context.windSpeeds.ToList();
    }
}