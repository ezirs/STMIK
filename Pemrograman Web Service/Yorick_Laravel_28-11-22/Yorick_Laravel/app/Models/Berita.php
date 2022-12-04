<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Cviebrock\EloquentSluggable\Sluggable;

class Berita extends Model
{
    use HasFactory;
    use Sluggable;

    protected $guarded = ['id'];

    public function kategori() {
        return $this->belongsTo(Kategori::class);
    }

    public function sluggable(): array
    {
        return [
            'slug' => [
                'source' => ['judul_berita']
            ]
        ];
    }

    public function getRouteKeyName()
    {
        return 'slug';
    }

}
