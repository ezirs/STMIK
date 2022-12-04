@extends('pages.dashboard.main')
@section('container')

<div class="content-header">
    <div class="container-fluid" style="margin-top: -4em">
        <div class="col-sm-12 mb-4">
            <h1 class="m-0">Halaman Berita</h1>
        </div>
        <hr class="bg-white mb-4">
    </div>
    <div class="card-body">
        @if(session()->has('success'))
            <div class="alert alert-success" role="alert">
                {{ session('success') }}
            </div>
        @endif
        <a href="/dashboard/berita/create" class="btn btn-primary mb-3">Tambah Berita</a>
        <table id="example2" class="table table-striped table-hover text-center table-bordered">
            <thead>
                <tr>
                    <th scope="col">No</th>
                    <th scope="col">Judul Berita</th>
                    <th scope="col">Kategori</th>
                    <th scope="col">Action</th>
                </tr>
            </thead>
            <tbody>
                @foreach ($beritas as $berita)
                    <tr>
                        <th>{{ $loop->iteration }}</th>
                        <td>{{ $berita->judul_berita }}</td>
                        <td>{{ $berita->kategori->nama }}</td>
                        
                        <td>
                            <a href="/dahsboard/berita/{{ $berita->slug }}" class="btn btn-outline-info"><i class="far fa-eye nav-icon"></i></a>
                            <a href="/dahsboard/berita/{{ $berita->slug }}/edit" class="btn btn-outline-warning"><i class="far fa-edit nav-icon"></i></a>
                            <form action="/dashboard/berita/{{ $berita->slug }}" method="POST" class="d-inline">
                                @method('delete')
                                @csrf
                                <button class="btn btn-outline-danger" onclick="return confirm('Yakin akan menghapus data?')"><i class="nav-icon fas fa-trash-alt"></i></button>
                            </form>
                        </td>
                    </tr>
                @endforeach
                
            </tbody>
        </table>
    </div>
        
    </div>
</div>

@endsection