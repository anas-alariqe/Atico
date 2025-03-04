window.intersectionObserverInstance = null;

window.startIntersectionObserver = () => {
    // إزالة أي مراقب قديم
    if (window.intersectionObserverInstance) {
        window.intersectionObserverInstance.disconnect();
    }

    const sections = document.querySelectorAll('.Check_InSection');
    if (!sections.length) return;

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            const target = entry.target;
            if (entry.isIntersecting) {
                if (entry.intersectionRatio >= 0.3)
                    target.classList.add('visible');
                else if (entry.intersectionRatio <= 1)
                    target.classList.remove('visible');

                if (target.classList.contains('X'))
                    target.classList.add('visible');
            } else {
                if (entry.intersectionRatio <= 0)
                    target.classList.remove('visible');
            }
        });
    }, {
        threshold: 0.3
    });

    sections.forEach(section => observer.observe(section));

    window.intersectionObserverInstance = observer;
};

document.addEventListener("DOMContentLoaded", () => {
    window.startIntersectionObserver();
});
