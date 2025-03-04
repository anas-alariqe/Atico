
    // تحديد جميع العناصر التي تحتوي على الكلاس 'Check_InSection'
    const sections = document.querySelectorAll('.Check_InSection');

    // إعداد Intersection Observer
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
        const target = entry.target;
        if (entry.isIntersecting) {
            if(entry.intersectionRatio >= 0.3)
            target.classList.add('visible'); // للظهور عند التمرير للأسفل
            else if(entry.intersectionRatio <=1)
            target.classList.remove('visible');
            if(target.classList.contains('X'))
            target.classList.add('visible'); // للظهور عند التمرير للأسفل
            
        } 
        else {
            if(entry.intersectionRatio <=0)
            target.classList.remove('visible'); // إخفاء العنصر
        }
        });
    }, {
        threshold: 0.3 // متى يبدأ العنصر بالظهور أو الاختفاء (30% من حجمه)
    });
    

    // تطبيق المراقبة على كل قسم
    sections.forEach(section => {
        observer.observe(section);
    });  
