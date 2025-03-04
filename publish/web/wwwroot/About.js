  document.addEventListener("DOMContentLoaded", () => {
    const stickyWrap = document.querySelector(".sticky-About_wrap");
    const headings = stickyWrap.querySelectorAll(".sticky-About h1");

    // إجمالي ارتفاع القسم
    const wrapHeight = stickyWrap.offsetHeight;
    // عدد العناوين
    const headingsCount = headings.length;

    window.addEventListener("scroll", () => {
      // موضع التمرير العمودي بالنسبة إلى العنصر
      const wrapTop = stickyWrap.getBoundingClientRect().top;
      const wrapBottom = stickyWrap.getBoundingClientRect().bottom;

      // تحقق إذا كان التمرير داخل العنصر
      if (wrapTop <= window.innerHeight && wrapBottom >= 0) {
        // حساب نسبة التمرير داخل العنصر
        const progress = Math.min(Math.max((window.innerHeight - wrapTop) / wrapHeight, 0), 1);

        // حساب العنصر الذي يجب أن يكون مميزًا
        const focusedIndex = Math.floor(progress * headingsCount);

        // إزالة الكلاس "Foucsed" من جميع العناوين
        headings.forEach((heading, index) => {
          if (index === focusedIndex) {
            heading.classList.add("Foucsed");
          } else {
            heading.classList.remove("Foucsed");
          }
        });
      }
    });
  });

