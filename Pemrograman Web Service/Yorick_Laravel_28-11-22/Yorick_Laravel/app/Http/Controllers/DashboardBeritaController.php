<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Str;
use App\Models\Berita;
use App\Models\Kategori;
use \Cviebrock\EloquentSluggable\Services\SlugService;

class DashboardBeritaController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view('pages/dashboard/berita/index', [
            'beritas' => Berita::all()  
        ]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('pages/dashboard/berita/create', [
            'kategori' => Kategori::all()
        ]);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $validatedData = $request->validate([
            'judul_berita' => 'required|max:255',
            'slug' => 'required',
            'kategori_id' => 'required',
            'isi_berita' => 'required'
        ]);

        $limit = 100;

        $validatedData['excerpt'] = Str::limit(strip_tags($request->isi_berita), $limit);

        Berita::create($validatedData);

        return redirect()->route('dashboardBerita')->with('success', 'Berita Baru Berhasil Ditambahkan!');
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($slug)
    {
        return view('pages/dashboard/berita/show', [
            'berita' => Berita::where('slug', $slug)->first()
        ]);
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($slug)
    {
        return view('pages/dashboard/berita/edit', [
            'berita' => Berita::where('slug', $slug)->first()
        ]);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($slug)
    {
        Berita::where('slug', $slug)->delete();
        return redirect()->route('dashboardBerita')->with('success', 'Data Berhasil Di Hapus');
    }

    public function checkSlug(Request $request)
    {
        $slug = SlugService::createSlug(Berita::class, 'slug', $request->judul_berita);
        return response()->json(['slug' => $slug]);
    }
}
