@extends('pages.dashboard.main')
@section('container')

    <div class="content-header">
        <div class="card-body" style="margin-top: -4rem">
            <article>
                <h4 class="mb-3">{{ $berita->judul_berita }}</h4>
                <hr style="background-color: white">
                <p>{!! $berita->isi_berita !!}</p>
                <a href="{{ route('dashboardBerita') }}" class="btn btn-success">Kembali Ke Berita Utama</a>
                <a href="{{ route('dashboardBeritaEdit', $berita->slug) }}" class="btn btn-success">Edit</a>
                <form action="{{ route('dashboardBeritaDelete', $berita->slug) }}" method="POST" class="d-inline">
                    @method('delete')
                    @csrf
                    <button class="btn btn-outline-danger" onclick="return confirm('Yakin akan menghapus data?')"><i class="nav-icon fas fa-trash-alt"></i></button>
                </form>
            </article>
        </div>
    </div>

@endsection