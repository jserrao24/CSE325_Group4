function confirmDelete() {
  return new Promise((resolve) => {
    Swal.fire({
      title: "Are you sure?",
      text: "You will not be able to recover this hotel!",
      icon: "warning",
      showCancelButton: true,
      confirmButtonColor: "#3085d6",
      cancelButtonColor: "#d33",
      confirmButtonText: "Yes, delete it!",
    }).then((result) => {
      resolve(result.isConfirmed);
    });
  });
}
