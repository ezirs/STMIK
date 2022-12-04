@extends('layouts/app')

@section('container')

<section>
    @if (session()->has('success'))
        <div class="alert alert-success alert-dismissible fade show" role="alert">
            {{ session('success') }}
            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        </div>
    @endif

    @if (session()->has('error'))
        <div class="alert alert-danger alert-dismissible fade show" role="alert">
            {{ session('error') }}
            <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
        </div>
    @endif

    <div class="card col-mb-6 col-lg-6 mx-auto shadow">
        <div class="card-body">
            <h3 class="card-title d-flex text-center mb-3 align-items-center">Login</h3>
            <form action="{{ route('postLogin') }}" method="POST">
                @csrf
                <div class="form-floating mb-3">
                    <input type="email" class="form-control" id="email" name="email" placeholder="name@example.com" value="{{ old('email') }}" required>
                    <label for="floatingInput">Email address</label>
                    @error('email')
                    <div class="invalid-feedback">
                        {{ $message }}
                    </div>
                    @enderror
                </div>
                <div class="form-floating mb-3">
                    <input type="password" class="form-control" id="password" name="password" placeholder="Password" required>
                    <label for="floatingInput">Password</label>
                </div>
                <button type="submit" class="btn btn-outline-primary w-100">Login</button>
                <div class="my-3 text-center">
                    <small>Belum punya akun ? <a href="{{ route('register') }}" style="text-decoration: none">Register</a></small>
                </div>
            </form>
        </div>
    </div>
</section>

@endsection