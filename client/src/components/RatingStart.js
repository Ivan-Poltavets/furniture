import React from 'react';

const RatingStars = ({ averageRating }) => {

    const fullStars = Math.floor(averageRating);

    // Calculate the remaining part of the rating
    const remainder = averageRating - fullStars;

    // Create an array to represent the stars
    const stars = [];

    // Add full gold stars
    for (let i = 0; i < fullStars; i++) {
        stars.push(<span key={i} className="gold-star">★</span>);
    }

    // Add half gold star if there is a remainder
    if (remainder >= 0.5) {
        stars.push(<span key="half-star" className="gold-star">★</span>);
    }

    // Fill the rest with gray stars
    while (stars.length < 5) {
        stars.push(<span key={stars.length} className="gray-star">★</span>);
    }
    return <div className="rating-stars">{stars}</div>;
};

export default RatingStars;