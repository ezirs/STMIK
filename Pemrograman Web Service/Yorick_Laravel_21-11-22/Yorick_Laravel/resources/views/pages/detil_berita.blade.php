@extends('layouts/app')

@section('container')
<h1>{{ $db->judul_berita }}</h1>

<section>
    <div class="card mb-3 w-100">
        <div class="row g-0 p-2 align-items-center">
            <div class="col-md-4 text-center">
                <img src="{{ asset($db->foto) }}" style="height: 200px;" class="img-fluid rounded"alt="{{ $db->judul_berita }}">
            </div>
            <div class="col-md-8 text-center">
                <div class="card-body">
                    <p class="card-text">{{ $db->isi_berita }}</p>
                    <small>{{ $db->kategori->nama }}</small>
                </div>
            </div>
        </div>
    </div>
    <div>
        <a href="{{ route("berita") }}" class="btn btn-outline-danger">Kembali</a>
    </div>

    @if(!$db)
        <div class="text-center">
            <h3>Berita tidak ada</h3>
        </div>
    @endif
</section>

@endsection